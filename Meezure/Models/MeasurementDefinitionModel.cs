﻿using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace Meezure
{
	public class MeasurementDefinitionModel
	{

		[PrimaryKey]
		public int Id {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		[OneToMany(CascadeOperations = CascadeOperation.All)]
		public List<MeasurementGroupDefinitionModel> MeasurementGroupDefinitions {
			get;
			set;
		}

		[OneToMany(CascadeOperations = CascadeOperation.All)]
		public List<ProfileMeasurementDefinitionModel> ProfileMeasurementDefinitions {get;set;}


	}
}

