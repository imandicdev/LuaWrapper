using System;
using LuaWrapper;


namespace LuaWrapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IntPtr luaState = Lua.luaL_newstate();
            Lua.luaL_openlibs(luaState);
            string luaString = "print('Hello World');";
            Lua.luaL_dostring(luaState, luaString);
            Lua.lua_close(luaState);

        }
    }
}
