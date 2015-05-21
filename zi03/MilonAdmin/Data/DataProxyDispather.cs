using System;
using System.Collections.Generic;
using System.Text;

namespace MilonAdmin.Data {
	public class DataProxyDispather {
		#region Singleton pattern
		private static DataProxyDispather _instance;

		public static DataProxyDispather Instance {
			get {
				if (_instance == null) {
					_instance = new DataProxyDispather( );
				}
				return _instance;
			}
		}
		#endregion

		#region Dispather pattern
		private IDataProxy _connectedProxy;
		private IDataProxy _disconnectedProxy;
		private ConnectionMode _mode;

		public ConnectionMode Mode {
			get {
				return this._mode;
			}
			set {
				this._mode = value;
			}
		}

		public IDataProxy DataProxy {
			get {
				if(this._mode == ConnectionMode.Polaczeniowy) {
					return this._connectedProxy;
				}else {
					return this._disconnectedProxy;
				}
			}
		}
		#endregion

		public DataProxyDispather( ) {
			this._mode = ConnectionMode.Bezpolaczeniowy;
			this._connectedProxy = new ConnectedDataProxy( );
			this._disconnectedProxy = new DisconnectedDataProxy( );
		}
	}
}
