using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave2.DataStructure;
using System.Data.SQLite;
using System.IO;



namespace Wave2.Classes
{
    class List
    {
        #region Fields

        private static string[] wmpSupportedFormats = { ".wav", ".aac", ".wma", ".wmv", ".avi", ".mpg", ".mpeg", ".m1v", ".mp2", ".mp3", ".mpa", ".mpe", ".m3u", ".mp4", ".mov", ".3g2", ".3gp2", ".3gp", ".3gpp", ".m4a", ".cda", ".aif", ".aifc", ".aiff", ".mid", ".midi", ".rmi", ".mkv", ".WAV", ".AAC", ".WMA", ".WMV", ".AVI", ".MPG", ".MPEG", ".M1V", ".MP2", ".MP3", ".MPA", ".MPE", ".M3U", ".MP4", ".MOV", ".3G2", ".3GP2", ".3GP", ".3GPP", ".M4A", ".CDA", ".AIF", ".AIFC", ".AIFF", ".MID", ".MIDI", ".RMI", ".MKV" };
        static SongList CurrentPlaylist = new SongList();
        public static bool IsPlaylistEmpty { get { return CurrentPlaylist.IsEmpty(); } }

        #endregion

        #region Properties

        public static string GetFirstTrack
        {
            get
            {
                if (IsPlaylistEmpty) return null;
                return CurrentPlaylist.GetHeadData;
            }
        }

        public static string GetRandomTrack
        {
            get
            {
                if (IsPlaylistEmpty) return null;
                return CurrentPlaylist.SelectRandomObject();
            }
        }

        public static string[] GetPlaylist
        {
            get
            {
                string[] Names = CurrentPlaylist.GetAllMembers();

                for (int i = 0; i < Names.Length; i++)
                {
                    Names[i] += Names[i] + "\n";
                }
                return Names;
            }
        }

        public static string[] GetListOfNames
        {
            get
            {
                string[] Names = CurrentPlaylist.GetAllMembers();

                for (int i = 0; i < Names.Length; i++)
                {
                    Names[i] = Path.GetFileName(Names[i]);
                }
                return Names;
            }
        }

        #endregion

        public static string SearchByName(string name)
        {
            return CurrentPlaylist.SearchByName(name);
        }

        public static void NewPlaylist()
        {
            CurrentPlaylist = new SongList();
        }

        public static void LoadPlaylist(string[] PlaylistText)
        {
            NewPlaylist();
            CurrentPlaylist.AddRange(PlaylistText);
            foreach (var item in CurrentPlaylist.GetAllMembers())
            {
                System.Windows.Forms.MessageBox.Show(item);
            }
        }

        public static void LoadLibraryPlaylist(string[] PlaylistText)
        {
            NewPlaylist();
            CurrentPlaylist.AddRange(PlaylistText);
   //         foreach (var item in CurrentPlaylist.GetAllMembers())
   //         {
    //            System.Windows.Forms.MessageBox.Show(item);
     //       }
     //       CurrentPlaylist = new SongList();

        }

        public static void RemoveItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                CurrentPlaylist.Remove(items[i]);
            }
        }

        public static void AddFiles(string[] addresses)
        {
            foreach (string file in addresses)
            {
                CurrentPlaylist.Add(file);
            }
        }

        public static void AddToLibrary(string[] addresses)
        {
            foreach (string file in addresses)
            {

                TagLib.File tagFile = TagLib.File.Create(file);
                string title = tagFile.Tag.Title;
                string[] artist = tagFile.Tag.Performers;
                string album = tagFile.Tag.Album;
                string[] albumartists = tagFile.Tag.AlbumArtists;
                string[] genre = tagFile.Tag.Genres;
                uint track = tagFile.Tag.Track;
                uint disc = tagFile.Tag.Disc;
                uint year = tagFile.Tag.Year;



                using (SQLiteConnection conn = new SQLiteConnection("data source = Wave.db"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        string strSql = $"INSERT INTO[Track] (FilePath, TrackTitle, Artists, AlbumTitle, AlbumArtists, Genres, TrackNumber, DiscNumber, Year) VALUES('{file}', '{title}', '{artist[0]}', '{album}', '{albumartists[0]}', '{genre[0]}', '{track}', '{disc}', '{year}')";
                        cmd.CommandText = strSql;
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        public static void AddFolder(string folderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            IEnumerable<FileInfo> files = dir.EnumerateFiles("*", SearchOption.AllDirectories);
            var items = files.Where(f => wmpSupportedFormats.Contains(f.Extension));

            foreach (FileInfo fi in items)
            {
                CurrentPlaylist.Add(fi.FullName);
            }
        }

        //next or previous
        public static string SelectTrack(char N_or_P, string curTrack, bool _repeat, bool _shuffle)
        {
            if (N_or_P == 'N' || N_or_P == 'n')
            {
                if (_shuffle == false)
                {
                    if (_repeat) return CurrentPlaylist.SelectNextObject(curTrack, true);
                    else return CurrentPlaylist.SelectNextObject(curTrack);
                }

                else
                {
                    return CurrentPlaylist.SelectRandomObject();
                }
            }

            else if (N_or_P == 'P' || N_or_P == 'p')
            {
                if (_shuffle == false)
                {
                    if (_repeat) return CurrentPlaylist.SelectPreviousObject(curTrack, true);
                    else return CurrentPlaylist.SelectPreviousObject(curTrack);

                }

                else
                {
                    return CurrentPlaylist.SelectRandomObject();
                }
            }

            else { return null; }
        }
    }
}
