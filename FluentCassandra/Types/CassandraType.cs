﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace FluentCassandra.Types
{
	public abstract class CassandraType
	{
		public abstract CassandraType SetValue(object obj);

		// these are put in as stubs so that implicity references against cassandra type compile
		public static implicit operator byte[](CassandraType type) { throw new NotImplementedException(); }
		public static implicit operator string(CassandraType type) { throw new NotImplementedException(); }
	}
}