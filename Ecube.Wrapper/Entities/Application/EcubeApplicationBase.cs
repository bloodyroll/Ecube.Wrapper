using System;
using System.Runtime.InteropServices;

using Ecube.Wrapper.Entities.Database;


namespace Ecube.Wrapper.Entities.Application
{
	public abstract class EcubeApplicationBase : IDisposable
	{
		protected EcubeApplicationBase(object comObject)
		{
			ComObject = comObject;
			Id = Dyna.GetId();
		}

		private object ComObject
		{
			get;
			set;
		}

		public EcubeDatabase Database
		{
			get { return new EcubeDatabase(); }
		}

		public dynamic Dyna
		{
			get { return ComObject; }
		}

		public int Id
		{
			get;
			private set;
		}

		public void Dispose()
		{
			if (ComObject != null)
			{
				Marshal.ReleaseComObject(ComObject);
				ComObject = null;
			}
		}
	}
}