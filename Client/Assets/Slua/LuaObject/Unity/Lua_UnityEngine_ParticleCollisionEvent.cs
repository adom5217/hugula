﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleCollisionEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent o;
			o=new UnityEngine.ParticleCollisionEvent();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intersection(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent self;
			checkValueType(l,1,out self);
			pushValue(l,self.intersection);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent self;
			checkValueType(l,1,out self);
			pushValue(l,self.normal);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent self;
			checkValueType(l,1,out self);
			pushValue(l,self.velocity);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent self;
			checkValueType(l,1,out self);
			pushValue(l,self.collider);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleCollisionEvent");
		addMember(l,"intersection",get_intersection,null,true);
		addMember(l,"normal",get_normal,null,true);
		addMember(l,"velocity",get_velocity,null,true);
		addMember(l,"collider",get_collider,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleCollisionEvent),typeof(System.ValueType));
	}
}
