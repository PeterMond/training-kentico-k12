//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.OnlineForms.Types;
using CMS.OnlineForms;

[assembly: RegisterBizForm(FloridaEventRegistrationItem.CLASS_NAME, typeof(FloridaEventRegistrationItem))]

namespace CMS.OnlineForms.Types
{
	/// <summary>
	/// Represents a content item of type FloridaEventRegistrationItem.
	/// </summary>
	public partial class FloridaEventRegistrationItem : BizFormItem
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "BizForm.FloridaEventRegistration";


		/// <summary>
		/// The instance of the class that provides extended API for working with FloridaEventRegistrationItem fields.
		/// </summary>
		private readonly FloridaEventRegistrationItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// First name.
		/// </summary>
		[DatabaseField]
		public string FirstName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FirstName"), @"");
			}
			set
			{
				SetValue("FirstName", value);
			}
		}


		/// <summary>
		/// Last name.
		/// </summary>
		[DatabaseField]
		public string LastName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("LastName"), @"");
			}
			set
			{
				SetValue("LastName", value);
			}
		}


		/// <summary>
		/// Email.
		/// </summary>
		[DatabaseField]
		public string EmailInput
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EmailInput"), @"");
			}
			set
			{
				SetValue("EmailInput", value);
			}
		}


		/// <summary>
		/// Badge photo.
		/// </summary>
		[DatabaseField]
		public string BadgePhoto
		{
			get
			{
				return ValidationHelper.GetString(GetValue("BadgePhoto"), @"");
			}
			set
			{
				SetValue("BadgePhoto", value);
			}
		}


		/// <summary>
		/// Journalists.
		/// </summary>
		[DatabaseField]
		public bool Journalists
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("Journalists"), false);
			}
			set
			{
				SetValue("Journalists", value);
			}
		}


		/// <summary>
		/// Media name.
		/// </summary>
		[DatabaseField]
		public string MediaName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MediaName"), @"");
			}
			set
			{
				SetValue("MediaName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with FloridaEventRegistrationItem fields.
		/// </summary>
		[RegisterProperty]
		public FloridaEventRegistrationItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with FloridaEventRegistrationItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class FloridaEventRegistrationItemFields : AbstractHierarchicalObject<FloridaEventRegistrationItemFields>
		{
			/// <summary>
			/// The content item of type FloridaEventRegistrationItem that is a target of the extended API.
			/// </summary>
			private readonly FloridaEventRegistrationItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="FloridaEventRegistrationItemFields" /> class with the specified content item of type FloridaEventRegistrationItem.
			/// </summary>
			/// <param name="instance">The content item of type FloridaEventRegistrationItem that is a target of the extended API.</param>
			public FloridaEventRegistrationItemFields(FloridaEventRegistrationItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// First name.
			/// </summary>
			public string FirstName
			{
				get
				{
					return mInstance.FirstName;
				}
				set
				{
					mInstance.FirstName = value;
				}
			}


			/// <summary>
			/// Last name.
			/// </summary>
			public string LastName
			{
				get
				{
					return mInstance.LastName;
				}
				set
				{
					mInstance.LastName = value;
				}
			}


			/// <summary>
			/// Email.
			/// </summary>
			public string EmailInput
			{
				get
				{
					return mInstance.EmailInput;
				}
				set
				{
					mInstance.EmailInput = value;
				}
			}


			/// <summary>
			/// Badge photo.
			/// </summary>
			public string BadgePhoto
			{
				get
				{
					return mInstance.BadgePhoto;
				}
				set
				{
					mInstance.BadgePhoto = value;
				}
			}


			/// <summary>
			/// Journalists.
			/// </summary>
			public bool Journalists
			{
				get
				{
					return mInstance.Journalists;
				}
				set
				{
					mInstance.Journalists = value;
				}
			}


			/// <summary>
			/// Media name.
			/// </summary>
			public string MediaName
			{
				get
				{
					return mInstance.MediaName;
				}
				set
				{
					mInstance.MediaName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="FloridaEventRegistrationItem" /> class.
		/// </summary>
		public FloridaEventRegistrationItem() : base(CLASS_NAME)
		{
			mFields = new FloridaEventRegistrationItemFields(this);
		}

		#endregion
	}
}