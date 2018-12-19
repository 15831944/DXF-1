/***************************************************************************
* Copyright (C) 2017, Deping Chen, cdp97531@sina.com
*
* All rights reserved.
* For permission requests, write to the publisher.
*
* This software is distributed on an "AS IS" basis, WITHOUT WARRANTY OF ANY
* KIND, either express or implied.
***************************************************************************/
#pragma once

typedef void *HANDLE;

namespace DXF
{
	class CFileMapping
	{
	public:
		CFileMapping();
		CFileMapping(const char* FileName);
		~CFileMapping(void);
		void Open(const char* FileName);
		void Close();

		const unsigned char* GetStart() const{ return m_pStart;}
		const unsigned char* GetEnd() const{ return m_pEnd;}
	private:
		HANDLE m_hFile;//�򿪵��ļ����
		HANDLE m_hMapFile;//�ļ�ӳ����
		const unsigned char* m_pStart;//�ļ������ӳ���������ڴ��λ��
		const unsigned char* m_pEnd;//�ļ����յ�ӳ���������ڴ��λ��
	};

}
