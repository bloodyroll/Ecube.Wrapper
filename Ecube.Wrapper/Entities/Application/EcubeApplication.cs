using Ecube.Wrapper.Entities.Job;


namespace Ecube.Wrapper.Entities.Application
{
	public class EcubeApplication : EcubeApplication0850
	{
		private EcubeJob _job;

		public EcubeApplication(object comObject)
			: base(comObject)
		{
		}

		public EcubeJob Job
		{
			get
			{
				if (_job == null)
				{
					return _job = CreateJobObject();
				}
				return _job;
			}
		}

		public EcubeJob CreateJobObject()
		{
			if (Dyna == null)
			{
				return null;
			}
			object comObject = _CreateJobObject();
			return new EcubeJob(this, comObject);
		}
	}
}