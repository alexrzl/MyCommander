namespace BL
{
	public static class Dir
	{
		private static string DirPath { get; set; }
		private const string DIR_SIZE = "<Папка>";
		private const string DEFAULT_ATTRIBUTES = "----";
		private static readonly string[] SizeSuffixes = { "байт", "КБ", "МБ", "ГБ", "ТБ", "PB", "EB", "ZB", "YB" };

		public static List<DirStructure> GetDirectoriesInfo(string path)
		{
			ValidatedPath(path);
			return GetDirStructures();
		}

		public static string GetSizeSuffix(Int64 value, int decimalPlaces = 2) => SizeSuffix(value, decimalPlaces);

		public static void SetAttributes(string fullPath, FileAttributes  fileAttribute, bool status, SearchOption searchOption = SearchOption.TopDirectoryOnly)
		{
			if (!Directory.Exists(fullPath) && !File.Exists(fullPath))
			{
				throw new FileNotFoundException("Файл/Директория не найдена", nameof(fullPath));
			}

			if (searchOption != SearchOption.AllDirectories)
			{
				SetAttributes(fullPath, fileAttribute, status);
			}
			else
			{
				IEnumerable<string> fullPatrhList = Directory.EnumerateDirectories(fullPath, "*", searchOption);

				foreach (var item in fullPatrhList)
				{
					SetAttributes(item, fileAttribute, status);
				}
			}
		}

		private static void SetAttributes(string fullPath, FileAttributes fileAttribute, bool status)
		{
			if (status)
			{
				File.SetAttributes(fullPath, File.GetAttributes(fullPath) | fileAttribute);
			}
			else
			{
				File.SetAttributes(fullPath, File.GetAttributes(fullPath) & ~fileAttribute);
			}
		}

		private static List<DirStructure> GetDirStructures()
		{
			List<DirStructure> dirStructure = new List<DirStructure>();
			var result = new List<DirStructure>();

			if (DirPath != null)
			{
				string[] dirs = Directory.GetFileSystemEntries(DirPath);
				
				foreach (string dir in dirs)
				{
					var _dir = new DirStructure();
					_dir.Name = Path.GetFileName(dir);
					_dir.FullName = dir;
					// Определяем тип объекта (файл или директория)
					FileAttributes attr = File.GetAttributes(dir);

					if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
					{
						_dir.Type = Path.GetExtension(dir);
						_dir.TypeObject = Enums.TypeObject.File;
						FileInfo file = new FileInfo(dir);

						try
						{
							_dir.Size = SizeSuffix(file.Length, 2);
						}
						catch
						{
							_dir.Size = DIR_SIZE;
						}

					}
					else
					{
						_dir.Type = "";
						_dir.Size = DIR_SIZE;
						_dir.TypeObject = Enums.TypeObject.Directory;
					}

					// Получаем атрибуты файла/диреектроии
					_dir.Attribute = GetAttributesInfo(attr);
					_dir.Date = Directory.GetLastWriteTime(dir);
					dirStructure.Add(_dir);
				}

				result = dirStructure.OrderBy(x => x.TypeObject).ThenBy(x => x.Name).ToList();
				var parent = Directory.GetParent(DirPath);

				if (parent != null)
				{
					result.Insert(0, new DirStructure()
					{
						Name = "..",
						FullName = parent.FullName,
						TypeObject = Enums.TypeObject.Directory,
						Attribute = DEFAULT_ATTRIBUTES
					});
				}
			}

			return result;
		}

		private static void ValidatedPath(string path)
		{
			if (string.IsNullOrWhiteSpace(path))
			{
				throw new ArgumentNullException("Путь не может быть пустым или равным Null", nameof(path));
			}

			if (!Directory.Exists(path))
			{
				throw new ArgumentNullException("Не верный путь, такого каталога не существует", nameof(path));
			}

			DirPath = path;
		}

		private static string GetAttributesInfo(FileAttributes attr)
		{
			string[] attributes = { "-", "-", "-", "-" };

			if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				attributes[0] = "r";
			}

			if ((attr & FileAttributes.Archive) == FileAttributes.Archive)
			{
				attributes[1] = "a";
			}

			if ((attr & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				attributes[2] = "h";
			}

			if ((attr & FileAttributes.System) == FileAttributes.System)
			{
				attributes[3] = "s";
			}

			return string.Join("", attributes);
		}

		private static string SizeSuffix(Int64 value, int decimalPlaces = 2)
		{
			if (decimalPlaces < 0)
			{
				throw new ArgumentOutOfRangeException("Десятичный разряд не может быть отрицательным", nameof(decimalPlaces));
			}

			if (value < 0)
			{
				return "-" + SizeSuffix(-value, decimalPlaces);
			}

			if (value == 0)
			{
				return string.Format("{0:n" + decimalPlaces + "} bytes", 0);
			}

			// mag is 0 for bytes, 1 for KB, 2, for MB, etc.
			int mag = (int)Math.Log(value, 1024);
			// 1L << (mag * 10) == 2 ^ (10 * mag) 
			// [i.e. the number of bytes in the unit corresponding to mag]
			decimal adjustedSize = (decimal)value / (1L << (mag * 10));
			// make adjustment when the value is large enough that
			// it would round up to 1000 or more
			if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
			{
				mag += 1;
				adjustedSize /= 1024;
			}

			return string.Format("{0:n" + decimalPlaces + "} {1}", adjustedSize, SizeSuffixes[mag]);
		}
	}
}