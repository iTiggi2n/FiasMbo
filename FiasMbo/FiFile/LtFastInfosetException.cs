
using System;

namespace FiasOffSite.FI
{
	/// <summary>
	/// Returns detailed information about the last exception.
	/// </summary>
	public class LtFastInfosetException : Exception 
	{
		/// <summary>
		/// Initializes a new instance of the XmlException class.
		/// </summary>
		public LtFastInfosetException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the XmlException class with a specified error message. 
		/// </summary>
		/// <param name="message">The error description.</param>
		public LtFastInfosetException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the XmlException class.
		/// </summary>
		/// <param name="message">The description of the error condition.</param>
		/// <param name="innerException">The <see cref="Exception"/> that threw the XmlException, if any. This value can be a null reference (Nothing in Visual Basic).</param>
        public LtFastInfosetException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
