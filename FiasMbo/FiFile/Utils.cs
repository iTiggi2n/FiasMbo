
namespace FiasOffSite.FI
{
	/// <summary>
	/// Utility class.
	/// </summary>
	internal class Utils
	{
		internal static bool CompareByteArrays(byte[] array1, byte[] array2, int length)
		{
			// assumes both arrays are != null and are >= length
			for (var i = 0; i < length; i++)
			{
				if (array1[i] != array2[i])
				{
					return false;
				}
			}

			return true;
		}
	
		internal static bool CompareByteArrays(byte[] array1, byte[] array2)
		{
			if (array1 != null && array2 != null)
			{
				if (array1.Length == array2.Length)
				{
					return CompareByteArrays(array1, array2, array1.Length);
				}
			}
			else if (array1 == null && array2 == null)
			{
				return true;
			}

			return false;
		}

	}
}
