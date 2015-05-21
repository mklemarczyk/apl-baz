using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MilonAdmin.Common {
	public static class DataFinder {

		public static T DiscoverData<T>(object obj) where T : class {
			var row = obj as DataRowView;
			if (row != null) {
				return DiscoverData<T>(row);
			}
			return null;
		}

		public static T DiscoverData<T>(DataGridViewRow row) where T : class {
			if (row != null) {
				DataRowView vrow = row.DataBoundItem as DataRowView;
				if (vrow != null) {
					return DiscoverData<T>(vrow);
                }
			}
			return null;
		}

		public static T DiscoverData<T>(DataRowView row) where T : class {
			if (row != null) {
				T qrow = row.Row as T;
				return qrow;
			}
			return null;
		}
	}
}
