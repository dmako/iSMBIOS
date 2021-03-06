﻿
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Defines a value that contains the detailed information of a writer.
    /// </summary>
    public class SmbiosPropertiesTable : IDictionary<PropertyKey, object>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Dictionary<PropertyKey, object> _table;
        #endregion

        #region constructor/s

        #region [public] SmbiosPropertiesTable(): Initialize a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosPropertiesTable" /> class.
        /// </summary>
        public SmbiosPropertiesTable() => _table = new Dictionary<PropertyKey, object>();
        #endregion

        #endregion

        #region interfaces

        #region public indexers

        #region [public] (object) this[PropertyKey]: Gets or sets the element with the specified key
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the element with the specified key.
        /// </summary>
        /// <param name="key">The key of the element that is obtained or established.</param>
        /// <returns>
        /// The element with the specified key.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">The value of <paramref name="key" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.Collections.Generic.KeyNotFoundException">The property is retrieved and <paramref name="key" /> can not be found.</exception>
        /// <exception cref="T:System.NotSupportedException">The property is set and <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        public object this[PropertyKey key]
        {
            get => _table[key];
            set => _table[key] = value;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (int) Count: Gets the number of elements included in collection
        /// <inheritdoc />
        /// <summary>
        /// Gets the number of elements included in <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <returns>
        /// Number of elements contained in <see cref="T: System.Collections.Generic.ICollection`1" />.
        /// </returns>
        public int Count => _table.Count;
        #endregion

        #region [public] (bool) IsReadOnly: Gets a value that indicates whether collection is read-only
        /// <inheritdoc />
        /// <summary>
        /// Gets a value that indicates whether <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.
        /// </summary>
        /// <returns>
        /// Always returns <see langword="true" />.
        /// </returns>
        public bool IsReadOnly => true;
        #endregion

        #region [public] (ICollection<PropertyKey>) Keys: Gets an interface collection that contains the keys for the dictionary interface
        /// <inheritdoc />
        /// <summary>
        /// Gets an interface <see cref="T:System.Collections.Generic.ICollection`1" /> that contains the keys for the <see cref="T: System.Collections.Generic.IDictionary`2" /> interface.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Collections.Generic.ICollection`1" /> that contains the keys of the object that implements the <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </returns>
        public ICollection<PropertyKey> Keys => _table.Keys;
        #endregion

        #region [public] (ICollection<object>) Values: Gets a value that indicates whether collection is read-only
        /// <inheritdoc />
        /// <summary>
        /// Gets an interface <see cref="T:System.Collections.Generic.ICollection`1" /> that contains the values for the <see cref="T: System.Collections.Generic.IDictionary`2" /> interface.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Collections.Generic.ICollection`1" /> that contains the values of the object that implements the <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </returns>
        public ICollection<object> Values => _table.Values;
        #endregion

        #endregion

        #region public methods

        #region [public] (void) Add(KeyValuePair<PropertyKey, object>): Add an element to collection
        /// <inheritdoc />
        /// <summary>
        /// Add an element to <see cref = "T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">
        /// Object to be added to <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </param>
        /// <exception cref="T:System.NotSupportedException"><see cref="T:System.Collections.Generic.ICollection`1" /> is read only.</exception>
        public void Add(KeyValuePair<PropertyKey, object> item)
        {
            _table.Add(item.Key, item.Value);
        }
        #endregion

        #region [public] (void) Add(PropertyKey, object>): Add an element with the key and value provided to dictionary
        /// <inheritdoc />
        /// <summary>
        /// Add an element with the key and value provided to <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <param name="key">Object that is going to be used as the key of the element to be added.</param>
        /// <param name="value">The object to be used as the value of the element to be added.</param>
        /// <exception cref="T:System.ArgumentNullException">The value of <paramref name="key" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.ArgumentException">An element with the same key already exists in <see cref="T:System.Collections.Generic.IDictionary`2" />.</exception>
        /// <exception cref="T:System.NotSupportedException"><see cref="T:System.Collections.Generic.IDictionary`2" /> is read only.</exception>
        public void Add(PropertyKey key, object value)
        {
            _table.Add(key, value);
        }
        #endregion

        #region [public] (void) Clear(): Remove all the elements of collection
        /// <inheritdoc />
        /// <summary>
        /// Remove all the elements of <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <exception cref="T:System.NotSupportedException"><see cref="T:System.Collections.Generic.ICollection`1" /> is read only.</exception>
        public void Clear()
        {
            _table.Clear();
        }
        #endregion

        #region [public] (bool) Contains(KeyValuePair<PropertyKey, object>): Determines whether collection contains a specific value
        /// <inheritdoc />
        /// <summary>
        /// Determines whether <see cref="T:System.Collections.Generic.ICollection`1" /> contains a specific value.
        /// </summary>
        /// <param name="item">Object to be searched in <see cref="T:System.Collections.Generic.ICollection`1" /></param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="item" /> is in the array <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, <see langword="false" />.
        /// </returns>
        public bool Contains(KeyValuePair<PropertyKey, object> item) => _table.Contains(item);
        #endregion

        #region [public] (bool) ContainsKey(PropertyKey): Determines whether dictionary contains an element with the specified key
        /// <inheritdoc />
        /// <summary>
        /// Determines whether <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the specified key.
        /// </summary>
        /// <param name="key">Key to be searched in <see cref="T:System.Collections.Generic.IDictionary`2" />.</param>
        /// <returns>
        /// Is <see langword="true" /> if <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the key; otherwise, it is <see langword="false" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">The value of <paramref name="key" /> is <see langword="null" />.</exception>
        public bool ContainsKey(PropertyKey key) => _table.ContainsKey(key);
        #endregion

        #region [public] (void) CopyTo(KeyValuePair<PropertyKey, object>[], int): Copy the elements of collection into array, starting with a given index of array
        /// <inheritdoc />
        /// <summary>
        /// Copy the elements of <see cref="T:System.Collections.Generic.ICollection`1" /> into <see cref="T:System.Array" />, starting with a given index of <see cref="T:System.Array "/>.
        /// </summary>
        /// <param name="array">
        /// <see cref="T:System.Array" /> one-dimensional which is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// The matrix<see cref="T:System.Array" /> must have a zero base index.
        /// </param>
        /// <param name="arrayIndex">Zero-base index in the <paramref name = "array" /> where the copy starts.</param>
        /// <exception cref="T:System.ArgumentNullException">The value of <paramref name="array" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="arrayIndex" /> is less than 0.</exception>
        /// <exception cref="T:System.ArgumentException">The number of elements at the origin of <see cref="T:System.Collections.Generic.ICollection`1" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination of <paramref name="array" />.</exception>
        public void CopyTo(KeyValuePair<PropertyKey, object>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region [public] (IEnumerator) IEnumerable.GetEnumerator(): Returns an enumerator that processes an iteration in the collection
        /// <inheritdoc />
        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        #region [public] (IEnumerator<KeyValuePair<PropertyKey, object>>) GetEnumerator(): Returns an enumerator that processes an iteration in the collection
        /// <inheritdoc />
        /// <summary>
        /// Returns an enumerator that processes an iteration in the collection.
        /// </summary>
        /// <returns>
        /// Enumerator that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<KeyValuePair<PropertyKey, object>> GetEnumerator() => _table.GetEnumerator();
        #endregion

        #region [public] (bool) Remove(KeyValuePair<PropertyKey, object>): Remove the first occurrence of a specific object from the ICollection interface
        /// <inheritdoc />
        /// <summary>
        /// Remove the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1" /> interface.
        /// </summary>
        /// <param name="item">Object to be removed from <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>
        /// Is <see langword="true" /> if <paramref name="item" /> has been successfully removed from the interface <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, it is <see langword="false" />.
        /// This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException"><see cref="T:System.Collections.Generic.ICollection`1" /> is read only.</exception>
        public bool Remove(KeyValuePair<PropertyKey, object> item)
        {
            return _table.Remove(item.Key);
        }

        #endregion

        #region [public] (bool) Remove(PropertyKey): Remove the element with the specified key from dictionary
        /// <inheritdoc />
        /// <summary>
        /// Remove the element with the specified key from <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <param name="key">Key of the item to be removed.</param>
        /// <returns>
        /// Is <see langword="true" /> if the element is removed correctly; otherwise, it is <see langword="false" />.
        /// This method also returns <see langword="false" /> if <paramref name="key" /> was not found in the original <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">The value of <paramref name="key" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.NotSupportedException"><see cref="T:System.Collections.Generic.IDictionary`2" /> is read only.</exception>
        public bool Remove(PropertyKey key)
        {
            return _table.Remove(key);
        }
        #endregion

        #region [public] (bool) TryGetValue(PropertyKey, out object): Gets the value associated with the specified key
        /// <inheritdoc />
        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">Key whose value will be obtained.</param>
        /// <param name="value">
        /// When this method returns the result, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the parameter <paramref name="value" />.
        /// This parameter is passed without initializing.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the object that implements <see cref="T:System.Collections.Generic.IDictionary`2" /> contains an element with the key; otherwise, <see langword="false" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">The value of <paramref name="key" /> is <see langword="null" />.</exception>
        public bool TryGetValue(PropertyKey key, out object value) => _table.TryGetValue(key, out value);
        #endregion

        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return $"Count = {_table.Count}";
        }
        #endregion

        #endregion
    }
}
