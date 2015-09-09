using System.Collections.Generic;


namespace Ecube.Wrapper.Entities.TextOwner
{
	public partial class EcubeTextOwnerBase
	{
		/// <summary>
		/// Returns identifiers of texts that are bound to the current object. 
		/// </summary>
		/// <param name="textType">Returns only texts of a certain type.</param>
		/// <param name="searchString">Optional parameter that returns only those texts that correspond to the 'searchString'. 
		/// 'searchString' can also contain the wildcards '*' and '?'. Thus, texts with certain contents can quickly be found in a project.</param>
		/// <returns>Identifiers of texts.</returns>
		public List<int> GetTextIds(int textType = 0, string searchString = "")
		{
			dynamic array;
			GetTextIds(out array, textType, searchString);
			return ConvertObjectArrayToIntegerList(array);
		}
	}
}