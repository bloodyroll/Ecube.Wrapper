using Ecube.Wrapper.Entities.Application;


namespace Ecube.Wrapper.Entities.Device
{
	internal class EcubeDevice : EcubeObjectBase
	{
		public EcubeDevice(EcubeApplication application, object comObject)
			: base(application, comObject)
		{
		}
	}
}