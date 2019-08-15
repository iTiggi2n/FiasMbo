namespace FiasOffSite.FI
{
	/// <summary>
	/// Abstract base class of Fast Infoset encodings <see cref="FIRestrictedAlphabet"/> and <see cref="FIEncodingAlgorithm"/>.
	/// </summary>
	public abstract class FIEncoding
	{
		/// <summary>
		/// Creates an instance of FIEncoding.
		/// </summary>
        protected FIEncoding() { }

		/// <summary>
		/// Method used to encode the data in the derived concrete class.
		/// </summary>
		/// <param name="data">Data to encode</param>
		/// <returns>Encoded data.</returns>
		/// <remarks>The data to encode should be of a type expected by the specific derived concrete class.</remarks>
		public abstract byte[] Encode(object data);

		/// <summary>
		/// Method used to decode the data in the derived concrete class. 
		/// </summary>
		/// <param name="data">Data to decode</param>
		/// <returns>Decoded data</returns>
		/// <remarks>The decoded data must always return as a string value as this will be read by the FIReader as if it were over a standard XML text document. The string returned may be string representation of binary data, e.g. Hex or Base64 encoded. The client would be expected to decode to binary data as required in the same way they would if they were reading an plain XML text document.</remarks>
		public abstract string Decode(byte[] data);

		internal int TableIndex
		{
			get { return _tableIndex; }
			set { _tableIndex = value; }
		}

		private int _tableIndex;
	}
}
