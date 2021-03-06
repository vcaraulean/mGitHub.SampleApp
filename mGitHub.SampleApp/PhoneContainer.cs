﻿using System;
using Caliburn.Micro;

namespace mGitHub.SampleApp
{
	public class PhoneContainer : SimpleContainer
	{
		public PhoneContainer(Bootstrapper bootStrapper)
		{
			Activator = new InstanceActivator(bootStrapper, type => GetInstance(type, null));
		}

		public InstanceActivator Activator { get; private set; }

		protected override object ActivateInstance(Type type, object[] args)
		{
			return Activator.ActivateInstance(base.ActivateInstance(type, args));
		}
	}
}