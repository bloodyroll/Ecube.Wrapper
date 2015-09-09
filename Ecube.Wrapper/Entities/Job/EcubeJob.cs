using Ecube.Wrapper.Entities.Application;


namespace Ecube.Wrapper.Entities.Job
{
	public class EcubeJob : EcubeJobBase
	{
		public EcubeJob(EcubeApplication application, object comObject)
			: base(application, comObject)
		{
		}
	}
}