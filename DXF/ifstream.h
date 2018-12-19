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

#include "FileMapping.h"
#ifndef EOF
#define EOF -1
#endif

//�ļ�������ifstream�Ǹ��ܺõĶ��̶���ʽ�ļ����࣬���ܲ��ɿ���
//operator>>����Ī�������fail����read����ֻ����һ�������ݡ�
//����д������ģ���࣬Ҫ�ر�ע��setdelimiter������������Ϊ�˼�
//operator>>������ģ��û�Ӧ���ڵ���operator>>֮ǰ���á�
namespace DXF
{
	const int goodbit = 0x0;
	const int eofbit = 0x1;
	const int failbit = 0x2;
	const int statmask = 0x3;
	typedef unsigned char seekdir; 
	const seekdir beg=0, cur=1, end=2;

	//����Ӱ����ָ��Ĳ���������seekg�������״̬ʧ��(fail()==true)�������������ء�

	class ifstream
	{
	public:
		ifstream(void);
		ifstream(const char* filename);
		ifstream(const wchar_t* filename);
		void reset()
		{
			clear();
			seekg(0);
		}
		//call close()
		~ifstream(void);
		//open a file
		void open(const char* filename);
		void open(const wchar_t* filename);
		//close a file
		void close();
		//status
		//Determines if a file is open.
		bool is_open();
		// test if eofbit is set in stream state
		bool eof();
		// test if badbit or failbit is set in stream state
		bool fail();
		// test if no state bits are set
		bool good();
		// test if any stream operation has failed
		operator void*();
		// test if no stream operation has failed
		bool operator!();
		//������״̬
		void clear(int State=goodbit);
		//��ȡ��״̬
		int rdstate();
		//������ԭ״̬֮�������״̬
		void setstate(int state);
		//���ó��˿հ�֮���field�ָ�������Ӱ�����е�operator>>��
		//�������0����ʾֻ���ܿհ���Ϊ�ָ�����
		void setdelimiter(const char* delimiter);
		//������ֵ
		ifstream& operator>>(bool& Val);
		//���ַ���
		ifstream& operator>>(char* Str);
		//��ȡ��һ���ַ����������ǲ��Ƿָ�����
		ifstream& operator>>(char& Val);
		//��ȡ������
		ifstream& operator>>(float& Val);
		ifstream& operator>>(double& Val);
		//��ȡ����
		ifstream& operator>>(short& Val);
		ifstream& operator>>(unsigned short& Val);
		ifstream& operator>>(int& Val);
		ifstream& operator>>(unsigned int& Val);
		ifstream& operator>>(long& Val);
		ifstream& operator>>(unsigned long& Val);
		//ȡ�����ĵ�ǰָ��
		unsigned long tellg();
		//�������ĵ�ǰָ��
		ifstream& seekg(unsigned long pos);
		ifstream& seekg(long off, seekdir origin);
		//ȡ���ļ���С
		unsigned long getsize();
		//getline & read
		ifstream& getline(char *Str, unsigned int count);
		ifstream& read(char *Str, unsigned int count);
		//��count����numeric_limits<unsigned int>::max()ʱ��ʾֻ����stop,������count��
		//���ĵ�ǰָ��ǰ��count���ֽڡ��������֮ǰ�ҵ�stop�ַ�����ô���ĵ�ǰָ��ͣ��stop
		//�ַ�֮��
		ifstream& ignore(unsigned int count, char stop=EOF);
		//ͬ�ϡ���ͬ���ǿ��Դ�����stop�ַ���
		ifstream& ignore(unsigned int count, const char* stop);
		//���ĵ�ǰָ�����count���ֽڡ�����˵��ļ���ʼ֮ǰ��failbit�������ã�
		//ͬʱ�����ĵ�ǰָ��ָ���ļ���ʼ����
		ifstream& backward(unsigned int count);
		//�����հ�
		ifstream& skipws();
	private:
		void init();
		void getfld(char *buffer);
		void do_get(__int64& Val);
		void do_get(double& Val);
		bool isdelim(char code);
		CFileMapping m_FileMapping;
		const char* m_pStart;//�ļ������ӳ���������ڴ��λ��
		const char* m_pEnd;//�ļ����յ�ӳ���������ڴ��λ��
		const char* m_pCur;//��ǰ�ļ�ָ��λ��
		int m_state;
		char* m_delimiter;
	};
}
