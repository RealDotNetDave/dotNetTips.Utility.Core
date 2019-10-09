// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-28-2019
// ***********************************************************************
// <copyright file="Config.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.IO;
using System.Xml.Serialization;
using dotNetTips.Utility.Standard.Xml;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class Config.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Config<T> where T : class, new()
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static T _instance = new T();

        /// <summary>
        /// Prevents a default instance of the <see cref="Config{T}" /> class from being created.
        /// </summary>
        protected Config()
        {
            var localAppData = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            var fileName = $"{App.AppInfo.Product}.config";
            var folder = Path.Combine(localAppData, App.AppInfo.Company);
            this.ConfigFileName = Path.Combine(folder, fileName);
        }

        /// <summary>
        /// Gets or sets the name of the configuration file.
        /// </summary>
        /// <value>The name of the configuration file.</value>
        [XmlIgnore]
        public string ConfigFileName { get; private set; }

        /// <summary>
        /// Returns instance for the object.
        /// </summary>
        /// <value>The instance.</value>
        [XmlIgnore]
        public T Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// Loads this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public virtual bool Load()
        {
            if (File.Exists(this.ConfigFileName))
            {
                _instance = XmlHelper.DeserializeFromXmlFile<T>(this.ConfigFileName);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public virtual bool Save()
        {
            if (File.Exists(this.ConfigFileName))
            {
                File.Delete(this.ConfigFileName);
            }

            XmlHelper.SerializeToXmlFile(this.Instance, this.ConfigFileName);

            return true;
        }
    }
}
