using System.Collections.Generic;

using Ecube.Wrapper.Entities.Application;


namespace Ecube.Wrapper.Entities
{
	public abstract class EcubeObjectBase
	{
		protected EcubeObjectBase(EcubeApplication application, object comObject)
		{
			Application = application;
			ComObject = comObject;
		}

		public EcubeApplication Application
		{
			get;
			private set;
		}

		protected object ComObject
		{
			get;
			set;
		}

		protected dynamic Dyna
		{
			get { return ComObject; }
		}

		public static List<int> ConvertObjectArrayToIntegerList(object[] array)
		{
			if (array.Length < 2)
			{
				return new List<int>();
			}

			var ids = new List<int>(array.Length - 1);
			for (int i = 1; i < array.Length; i++)
			{
				ids.Add((int) array[i]);
			}
			return ids;
		}

		/// <summary>
		/// Gets the object's internal identifier.
		/// </summary>
		/// <returns>Internal identifier.</returns>
		public int GetId()
		{
			return Dyna.GetId();
		}

		/// <summary>
		/// Sets the object's internal identifier. Accepts different object identifiers, which point to a unique object (i.e. pin ids, symbol ids, etc.).
		/// </summary>
		/// <param name="id">Internal identifier.</param>
		/// <returns></returns>
		public int SetId(int id)
		{
			return Dyna.SetId(id);
		}
	}
}