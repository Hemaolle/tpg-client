﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Dystopia.Model;

namespace Dystopia.Dummy {
	public class DummyWorld : Dystopia.Model.World {

		public override List<Location> Locations {
			get { return Locations;}
			set;
		}
		private List<Location> locations; 


	}
}
