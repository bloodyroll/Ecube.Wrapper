namespace Ecube.Wrapper.Entities.Application
{
	public class EcubeApplication0850 : EcubeApplicationBase
	{
		public EcubeApplication0850(object comObject)
			: base(comObject)
		{
		}

		/// <summary>
		/// Returns an object, that enables the use of methods for reading and writing to a project (may also be called a job or drawing).
		/// Does not open a project but may connect the client to a project, which is already open within the given application.
		/// </summary>
		/// <returns></returns>
		protected object _CreateJobObject()
		{
			return Dyna.CreateJobObject();
		}
	}
}