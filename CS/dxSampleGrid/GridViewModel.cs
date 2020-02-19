using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using DevExpress.Mvvm;

namespace dxSampleGrid {
    public class GridViewModel : ViewModelBase {
        public GridViewModel() {
            PopulateItems();            
        }
        public ObservableCollection<ExpandoObject> Items {
            get { return GetValue<ObservableCollection<ExpandoObject>>(); }
            set { SetValue(value); }
        }
        void PopulateItems() {
            Items = new ObservableCollection<ExpandoObject>();
            for (int i = 0; i < 10; i++) {                
                dynamic dynObj = new ExpandoObject();
                dynObj.ID = i;
                dynObj.Name = $"Name{i}";
                Items.Add(dynObj);
            }
        }

        int count;
        public void AddNew() {
            foreach (var item in Items) {
                ((IDictionary<string, object>)item)[$"Column{count}"] = "NewValue";
            }
            count++;
        }
    }
}
