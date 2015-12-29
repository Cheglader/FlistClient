using PCLStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlistClient
{
    /*
    static interface CacheManager
    {
        Task<IFolder> GetStateFolder(bool createIfNonExistent);
    }*/
    public static class UniversalCacheManager
    {
        public static async Task<IFolder> GetStateFolder(bool createIfNonExistent)
        {/*
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder dataFolder = null;

            if (createIfNonExistent)
                dataFolder = await rootFolder.CreateFolderAsync("state", CreationCollisionOption.OpenIfExists);
            else
            {
                try
                {
                    dataFolder = await rootFolder.GetFolderAsync("state");
                }
                catch (PCLStorage.Exceptions.DirectoryNotFoundException)
                {
                    return null;
                }
            }

            return dataFolder;*/
            return await GetFolderByName("state", createIfNonExistent);
        }
        private static async Task<IFolder> GetFolderByName(string folderName, bool createIfNonExistent)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder dataFolder = null;

            try
            {
                dataFolder = await rootFolder.GetFolderAsync(folderName);
            }
            catch (PCLStorage.Exceptions.DirectoryNotFoundException)
            {
                return null;
            }
            return dataFolder;
        }
        public static async Task<IFolder> GetCacheFolder(bool createIfNonExistent)
        {
            return await GetFolderByName("cache", createIfNonExistent);
        }
        public static async Task<IFile> CreateCacheFile(string filename)
        {
            IFolder cacheFolder = await GetCacheFolder(true);
            return await cacheFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
        }
    }
}
