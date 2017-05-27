// PowerToolsHelper.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

#include <string>
#include <vector>
#include <cstdint>

//Installation Information
#include <Msi.h>

typedef unsigned long ulong_t;

using namespace System;

namespace PowerToolsHelper
{
	//InstalledProduct contains information related to installed products
	// on the windows platform (information is retrieved using the Msi.dll API)
	public ref struct InstalledProduct
	{
	public:
		property System::String^ m_strGUID; //Product GUID
		property System::String^ m_strName; //Product Name
		property System::String^ m_strPath; //Installed To Path
		property System::UInt32^ m_uiVersionMajor; //Product Major Version
		property System::UInt32^ m_uiVersionMinor; //Product Minor Version
	};

	public ref class PowerToolsHelper
	{
	public:
		static array<InstalledProduct^>^ GetListOfInstalledProducts()
		{
			//C++ objects
			int iProducts = 0;
			wchar_t wszProductGUID[64] = { };
			std::vector<std::wstring> vec_str_Products;
			wchar_t wszReturnedValue[2048];
			ulong_t ulBufferSize = 2048;

			//CLI garbage collected objects
			array<InstalledProduct^>^ arrInstalledProducts = nullptr;

			//Get the GUIDs for all the installed products
			while (ERROR_SUCCESS == MsiEnumProductsW(iProducts, wszProductGUID))
			{
				vec_str_Products.push_back(std::wstring(wszProductGUID));
				iProducts++;
			}

			//initialize and allocate the array of InstalledProduct 
			// to match the number of product GUIDs returned
			arrInstalledProducts = gcnew array<InstalledProduct^>(iProducts);

			//Get the installation information for the list of product GUIDs
			for (int iProduct = 0; iProduct < iProducts; iProduct++)
			{
				//Create a new InstalledProduct object
				arrInstalledProducts[iProduct] = gcnew InstalledProduct();

				//Assign the GUID
				arrInstalledProducts[iProduct]->m_strGUID = gcnew System::String(vec_str_Products[iProduct].data());

				//Set the return buffer size 
				ulBufferSize = 2048;

				//Get the name of the product
				if (ERROR_SUCCESS == MsiGetProductInfoW(vec_str_Products[iProduct].data(),
														INSTALLPROPERTY_PRODUCTNAME,
														wszReturnedValue,
														&ulBufferSize))
				{
					arrInstalledProducts[iProduct]->m_strName = gcnew System::String(wszReturnedValue, 0, ulBufferSize);
				}

				//Set the return buffer size
				ulBufferSize = 2048;

				//Get the installation path for the product
				if (ERROR_SUCCESS == MsiGetProductInfoW(vec_str_Products[iProduct].data(),
														INSTALLPROPERTY_INSTALLLOCATION,
														wszReturnedValue,
														&ulBufferSize))
				{
					arrInstalledProducts[iProduct]->m_strPath = gcnew System::String(wszReturnedValue, 0, ulBufferSize);
				}
				else
				{
					System::Console::WriteLine(L"Failed to Get Install Path");
				}

				//Set the return buffer size
				ulBufferSize = 2048;

				//Get the major version for the product
				if (ERROR_SUCCESS == MsiGetProductInfoW(vec_str_Products[iProduct].data(),
														INSTALLPROPERTY_VERSIONMAJOR,
														wszReturnedValue,
														&ulBufferSize))
				{
					arrInstalledProducts[iProduct]->m_uiVersionMajor = gcnew System::UInt32(std::stoul(wszReturnedValue));
				}

				//Set the return buffer size
				ulBufferSize = 2048;

				//Get the minor version for the product
				if (ERROR_SUCCESS == MsiGetProductInfoW(vec_str_Products[iProduct].data(),
														INSTALLPROPERTY_VERSIONMINOR,
														wszReturnedValue,
														&ulBufferSize))
				{
					arrInstalledProducts[iProduct]->m_uiVersionMinor = gcnew System::UInt32(std::stoul(wszReturnedValue));
				}
			}//end for iProduct

			return arrInstalledProducts;

		}//end GetListOfInstalledProducts
	};



}//end namespace PowerToolsHelper