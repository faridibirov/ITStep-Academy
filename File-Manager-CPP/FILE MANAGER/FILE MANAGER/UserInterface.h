#pragma once
#include "File.h"
#include "Folder.h"
#include <Windows.h>
#include <time.h>
#define �������� Run()

class UserInterface
{
public:
	
	UserInterface() {}

	void ��������;
	

	WORD Attributes = 0;

	void SetConsoleColour(WORD* Attributes, DWORD Colour);

	void ResetConsoleColour(WORD Attributes);

private:
	File newfile;
	Folder newfolder;
};

