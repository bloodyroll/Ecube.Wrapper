using Ecube.Wrapper.Entities.Application;


namespace Ecube.Wrapper.Entities.TextOwner
{
	public partial class EcubeTextOwnerBase : EcubeObjectBase
	{
		public EcubeTextOwnerBase(EcubeApplication application, object comObject)
			: base(application, comObject)
		{
		}

		/// <summary>
		/// Returns the total number and identifiers of texts that are bound to the current object.
		/// </summary>
		/// <param name="ids">Identifiers of texts.</param>
		/// <param name="textType">Returns only texts of a certain type.</param>
		/// <param name="searchString">Optional parameter that returns only those texts that correspond to the 'searchString'. 
		/// 'searchString' can also contain the wildcards '*' and '?'. Thus, texts with certain contents can quickly be found in a project.</param>
		/// <returns>Number of the text found.</returns>
		private int GetTextIds(out object ids, int textType = 0, string searchString = "")
		{
			ids = null;
			return Dyna.GetTextIds(ref ids, textType, searchString);
		}
	}
}