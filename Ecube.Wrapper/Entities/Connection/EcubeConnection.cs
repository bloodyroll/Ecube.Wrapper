using Ecube.Wrapper.Entities.Application;


namespace Ecube.Wrapper.Entities.Connection
{
	public class EcubeConnection : EcubeObjectBase
	{
		public EcubeConnection(EcubeApplication application, object comObject)
			: base(application, comObject)
		{
		}
	}
}