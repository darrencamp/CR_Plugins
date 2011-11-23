using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.StructuralParser;

namespace CR_ReturnValueNotUsed
{
	public class ReturnValueNotUsedIssue
	{
		public void CheckCodeIssue( CheckCodeIssuesEventArgs eventArg )
		{
			var types = new LanguageElementType[] { LanguageElementType.MethodCall };
			var elementFilter = new ElementTypeFilter( types );
			var enumerable = eventArg.GetEnumerable( eventArg.Scope, elementFilter );
			foreach ( var element in enumerable )
			{
				IMethodCallStatement methodCall = element as IMethodCallStatement;
				if ( methodCall == null )
					continue;

				IMethodElement methodDeclaration = methodCall.GetDeclaration() as IMethodElement;
				if ( methodDeclaration == null )
					continue;

				if ( methodDeclaration.MethodType == MethodTypeEnum.Function )
				{
					eventArg.AddHint( methodCall.FirstNameRange, "Return value is not used" );
				}
			}
		}
	}
}
