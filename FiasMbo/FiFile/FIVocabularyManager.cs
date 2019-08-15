
using System.Collections.Generic;

namespace FiasOffSite.FI
{
	/// <summary>
	/// Manages external vocabulary objects
	/// </summary>
	public class FIVocabularyManager
	{
		/// <summary>
		/// Create an instance of the VocabularyManager class.
		/// </summary>
		public FIVocabularyManager()
		{
			_uriToVocabularyMap = new Dictionary<string, FIExternalVocabulary>();
		}

		/// <summary>
		/// Adds a FIExternalVocabulary object to the manager.
		/// </summary>
		/// <param name="vocabulary">Object to add.</param>
		/// <exception cref="LtFastInfosetException">A vocabulary already exists for URI.</exception>
		public void AddVocabulary(FIExternalVocabulary vocabulary)
		{
			string uri = vocabulary.URI.ToString();
			if (_uriToVocabularyMap.ContainsKey(uri))
				throw new LtFastInfosetException("A vocabulary already exists for URI " + uri);

			_uriToVocabularyMap.Add(uri, vocabulary);
		}

		internal FIReaderVocabulary ReaderVocabulary(string uri)
		{
			FIExternalVocabulary vocab = null;
			if (_uriToVocabularyMap.TryGetValue(uri, out vocab))
				return vocab.Reader;

			return null;
		}

		internal FIWriterVocabulary WriterVocabulary(string uri)
		{
			FIExternalVocabulary vocab = null;
			if (_uriToVocabularyMap.TryGetValue(uri, out vocab))
				return vocab.Writer;

			return null;
		}

		private Dictionary<string, FIExternalVocabulary> _uriToVocabularyMap;
	}
}
