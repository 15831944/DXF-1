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

#include <string>
#include <vector>
#include <map>
#include <set>
using namespace std;
#include "acadconst.h"
#include "AcadEntities.h"
#include "ImpExpMacro.h"

namespace DXF {

struct EntAttribute;
class DXF_API DxfData
{
public:
	DxfData();
	virtual ~DxfData();
	std::shared_ptr<EntAttribute> FindEntity(int handle);
	void Reset();

	double m_LinetypeScale;

	//��ͼԪ���õ����͡�ͼ�㡢������ʽ����ע��ʽ�����Ա�ɾ����Ҳ�����Ա�������
	std::set<std::string> m_Linetypes;
	std::map<std::string, LayerData> m_Layers;
	std::map<std::string, TextStyleData> m_TextStyles;
	std::map<std::string, DimStyleData> m_DimStyles;
	std::map<std::string, MLeaderStyle> m_MLeaderStyles;
	std::map<std::string, TableStyle> m_TableStyles;

	//����ģ�Ϳռ����
	EntityList m_Objects;
	//�������в���, include *Papaer_Space
	std::map<std::string, std::shared_ptr<LayoutData>> m_Layouts;
	//����AutoCAD��Ķ���
	std::map<std::string, std::shared_ptr<BlockDef>> m_RealBlockDefs;

public: // Used internally
	int PrepareBeforeWrite();

private:
	friend class DxfReader;
	// Keep last generated block number, start from 1, *D1, *D2, etc
	mutable int m_TmpBlockNo;
};

}
