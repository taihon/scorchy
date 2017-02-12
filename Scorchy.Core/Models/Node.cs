using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Models
{
    public class Node : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public Guid? Guid { get; set; }
        public ObservableCollection<Node> ChildNodes { get; set; }

        public Node()
        {
            this.Guid = null;
            ChildNodes = new ObservableCollection<Node>();
        }
        public bool AddNodeWithParents(string path, Guid g)
        {
            if (path == null) return false;
            string[] parts = path.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 1)
            {
                ChildNodes.Add(new Node() { Name = parts[0], Guid = g });
                return true;
            }
            Node nodeToAdd = ChildNodes.FirstOrDefault(n => n.Name == parts[0]);
            if (nodeToAdd != null)
            {
                return nodeToAdd.AddNodeWithParents(string.Join("\\", parts.Skip(1)), g);
            }
            else
            {
                Node n = new Node() { Name = parts[0] };
                ChildNodes.Add(n);
                return n.AddNodeWithParents(string.Join("\\", parts.Skip(1)), g);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = "None")
        {
            if (PropertyChanged != null)
                if (property != "None")
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        private bool isSelected;
    }
}
