// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.23
// 

using Colyseus.Schema;

namespace SchemaTest.InstanceSharing {
	public partial class Player : Schema {
		[Type(0, "ref", typeof(Position))]
		public Position position = new Position();
	}
}
