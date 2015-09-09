using System;
using System.Runtime.InteropServices;

using Ecube.Wrapper.Entities.Application;


namespace Ecube.Wrapper.Entities.Job
{
	public class EcubeJobBase : EcubeObjectBase, IDisposable
	{
		public EcubeJobBase(EcubeApplication application, object comObject)
			: base(application, comObject)
		{
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