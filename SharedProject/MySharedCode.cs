using System;
namespace SharedProject
{
	public class MySharedCode
	{
		public MySharedCode()
		{
		}
		public string GetFilePath(string fileName)
		{

#if WINDOWS_UWP
            var FilePath = Path.Combine(
                Windows.Storage.ApplicationData.Current.LocalFolder.Path,
                filename);
#if __ANDROID__
               string LibraryPath =
                   Environment.GetFolderPath(
                       Environment.SpecialFolder.Personal); ;
               var FilePath = Path.Combine(LibraryPath, fileName);
#endif
#endif
			return FilePath;
		}
	}
}
