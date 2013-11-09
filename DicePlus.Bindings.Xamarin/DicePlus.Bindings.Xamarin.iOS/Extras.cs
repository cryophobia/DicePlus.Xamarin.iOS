using System;
using System.Runtime.InteropServices;

namespace DicePlus
{
	public partial class DicePlusHelper
	{
		public static void SetKey(byte[] keyArray, DPDiceManager dieManager){

			IntPtr unmanagedPointer = Marshal.AllocHGlobal(keyArray.Length);
			Marshal.Copy(keyArray, 0, unmanagedPointer, keyArray.Length);

			dieManager.Key = unmanagedPointer;

			Marshal.FreeHGlobal(unmanagedPointer);
		}
	}
}

