#region License

// Copyright 2005-2009 Paul Kohler (https://github.com/paul-kohler-au/minisqlquery). All rights reserved.
// This source code is made available under the terms of the Microsoft Public License (Ms-PL)
// http://minisqlquery.codeplex.com/license
#endregion

using System;

namespace MiniSqlQuery.Core.Commands
{
	/// <summary>
	/// 	The insert guid command.
	/// </summary>
	public class InsertGuidCommand : CommandBase
	{
		/// <summary>
		/// 	Initializes a new instance of the <see cref = "InsertGuidCommand" /> class.
		/// </summary>
		public InsertGuidCommand()
			: base("Insert GUID")
		{
			// todo SmallImage = ImageResource.;
		}

		/// <summary>
		/// 	Gets a value indicating whether Enabled.
		/// </summary>
		/// <value>The enabled state.</value>
		public override bool Enabled
		{
			get { return ActiveFormAsEditor != null; }
		}

		/// <summary>
		/// 	Execute the command.
		/// </summary>
		public override void Execute()
		{
			var editor = ActiveFormAsEditor;
			if (editor != null)
			{
				editor.InsertText(Guid.NewGuid().ToString());
			}
		}
	}
}