﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilder
{
	class Director
	{
		public void Construct(Builder builder)
		{
			builder.BuildHead();
			builder.BuildBody();
			builder.BuildHands();
			builder.BuildLegs();

		}
	}
}
