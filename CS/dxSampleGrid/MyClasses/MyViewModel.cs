using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dxSampleGrid {
    public class MyViewModel {
        public MyViewModel() {
            CreateList();
            GenerateColumns();
        }

        public ObservableCollection<ExpandoObject> PersonList { get; set; }
        public ObservableCollection<MyColumn> MyColumns { get; set; }

        void CreateList() {
            PersonList = new ObservableCollection<ExpandoObject>();
            for (int i = 0; i < 10; i++) {
                Person p = new Person(i);
                ExpandoObject persDictionary = new ExpandoObject();
                IDictionary<string, object> dict =  (IDictionary<string, object>)persDictionary;
                 dict["dFirstName"] = p.FirstName;
                 dict["dLastName"] = p.LastName;
                 dict["dAge"] = p.Age;
                 PersonList.Add(persDictionary);
            }
        }

        public void GenerateColumns() {
            MyColumns = new ObservableCollection<MyColumn>();
            MyColumns.Add(new MyColumn() { FieldName = "dFirstName" });
            MyColumns.Add(new MyColumn() { FieldName = "dLastName" });
            MyColumns.Add(new MyColumn() { FieldName = "dAge" });
        }

    }
}
