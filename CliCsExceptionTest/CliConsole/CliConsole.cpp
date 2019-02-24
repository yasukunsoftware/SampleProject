#include "pch.h"

using namespace System;

int main(array<System::String ^> ^args)
{
	MyCs::Class1^ cls = gcnew MyCs::Class1();
	int total = 0;
	try
	{
		total = cls->Add(2, 5);
		Console::WriteLine(total);
	}
	catch (MyCs::MyException^ e)
	{
		Console::WriteLine("MyException—áŠO‚ª”­¶‚µ‚Ü‚µ‚½ " + e->Mes->ToString() + " " + e->Id.ToString());
	}
	catch (Exception^ e)
	{
		Console::WriteLine(e);
	}
	finally
	{
		Console::WriteLine(total);
		total = -1;
	}

    return 0;
}
