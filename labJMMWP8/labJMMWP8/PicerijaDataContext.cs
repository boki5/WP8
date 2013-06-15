using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Data.Linq;
using Microsoft.Phone.Data.Linq.Mapping;

namespace labJMMWP8
{
    public class PicerijaDataContext : DataContext
{
    // Specify the connection string as a static, used in main page and app.xaml.
    public static string DBConnectionString = "Data Source=isostore:/Picerija.sdf";

    // Pass the connection string to the base class.
    public PicerijaDataContext(string connectionString): base(connectionString) { }

    // Specify a single table for the to-do items.
    public Table<PicerijaItem> PicerijaItems;
}

// Define the to-do items database table.
[Table]
public class PicerijaItem //: INotifyPropertyChanged, INotifyPropertyChanging
{
    // Define ID: private field, public property, and database column.
    private int _PicerijaItemId;

    [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
    public int PicerijaItemId
    {
        get
        {
            return _PicerijaItemId;
        }
        set
        {
            if (_PicerijaItemId != value)
            {
                //NotifyPropertyChanging("PicerijaItemId");
                _PicerijaItemId = value;
                //NotifyPropertyChanged("PicerijaItemId");
            }
        }
    }

    private int _telephone;
    [Column(IsPrimaryKey = false, IsDbGenerated = true, CanBeNull = true, AutoSync = AutoSync.OnInsert)]
    public int telephone
    {
        get
        {
            return _telephone;
        }
        set
        {
            if (_telephone != value)
            {
                //NotifyPropertyChanging("telephone");
                _telephone = value;
                //NotifyPropertyChanged("telephone");
            }
        }
    }

    private int _longituda;
    [Column(IsPrimaryKey = false, IsDbGenerated = true, CanBeNull = true, AutoSync = AutoSync.OnInsert)]
    public int longituda
    {
        get
        {
            return _longituda;
        }
        set
        {
            if (_longituda != value)
            {
                //NotifyPropertyChanging("telephone");
                _longituda = value;
                //NotifyPropertyChanged("telephone");
            }
        }
    }

    private int _latituda;
    [Column(IsPrimaryKey = false, IsDbGenerated = true, CanBeNull = true, AutoSync = AutoSync.OnInsert)]
    public int latituda
    {
        get
        {
            return _latituda;
        }
        set
        {
            if (_latituda != value)
            {
                //NotifyPropertyChanging("telephone");
                _latituda = value;
                //NotifyPropertyChanged("telephone");
            }
        }
    }

    private string _adresa;
    [Column(IsPrimaryKey = false, IsDbGenerated = true, CanBeNull = true, AutoSync = AutoSync.OnInsert)]
    public string adresa
    {
        get
        {
            return _adresa;
        }
        set
        {
            if (_adresa != value)
            {
                //NotifyPropertyChanging("telephone");
                _adresa = value;
                //NotifyPropertyChanged("telephone");
            }
        }
    }



    //public event PropertyChangedEventHandler PropertyChanged;

  //  event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
  //  {
  //      add { throw new NotImplementedException(); }
   //     remove { throw new NotImplementedException(); }
   // }
}

}