using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileTn.UI
{
	/// <summary>
	/// Source: http://motzcod.es/post/94643411707/enhancing-xamarin-forms-listview-with-grouping
	/// </summary>
	/// <typeparam name="K"></typeparam>
	/// <typeparam name="T"></typeparam>
	public class Grouping<K, T> : ObservableCollection<T>
	{
		public K Key { get; private set; }

		public Grouping(K key, IEnumerable<T> items)
		{
			Key = key;

			foreach (var item in items)
			{
				Items.Add(item);
			}
		}
	}
}
