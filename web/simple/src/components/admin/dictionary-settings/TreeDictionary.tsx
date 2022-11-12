import { Button, Card, Input, List, Tree } from "@douyinfe/semi-ui";
import React from "react";
import { Component, ReactNode } from "react";
import dictionarysettingapi from "../../../apis/dictionarysetting";
import { DictionarySettingDto } from "../../../modules/dictionarysetting/DictionarySettingDto";
import { SimpleInput } from "../../../modules/shareds/SimpleInput";
import './index.css'
import { IconSearch } from '@douyinfe/semi-icons';


interface IProps {

}

interface IState {
    input: SimpleInput,
    data: DictionarySettingDto[],
    value: [];
}

class TreeDictionary extends Component<IProps, IState>{
    state: Readonly<IState> = {
        input: {
            keywords: '',
            startTime: '',
            endTime: '',
            page: 1,
            pageSize: 20
        },
        data: [],
        value: []
    }

    constructor(props: any) {
        super(props)
        this.getlist()
    }

    /**
     * 获取字典设置列表
     */
    getlist() {
        dictionarysettingapi.GetListAsync(this.state.input)
            .then((res: any) => {
                var data = res.data as DictionarySettingDto[]
                this.setState({
                    data
                })
            })
    }

    onClick(data: any) {
        this.setState({
            value: data.value
        })
    }
    render(): ReactNode {
        var ref = React.createRef() as any;
        var { data, value, input } = this.state;
        const treeData =
            data.map(x => {
                return {
                    label: (<div onClick={() => this.onClick(x)}>
                        <span>{x.key}</span>
                    </div>
                    ),
                    key: x.id,
                }
            });

        return (
            <div style={{ height: "68vh" }}>
                <div className="dictionary">
                    <Input style={{ margin: '5px', width: "200px" }} value={input.keywords} prefix="搜索字典" showClear onChange={v => {
                        input.keywords = v
                        this.setState({ input })
                    }
                    } />
                    <Button icon={<IconSearch />} aria-label="搜索" onClick={() => this.getlist()} />
                </div>
                <div>
                    <Card
                        className="tree">
                        <Tree
                            ref={ref}
                            filterTreeNode
                            searchRender={false}
                            treeData={treeData}
                            blockNode={false}
                        />
                    </Card>
                    <Card
                        className="list">
                        <List
                            bordered
                            dataSource={value}
                            renderItem={(item: any) => <List.Item>{item}</List.Item>}
                        />
                    </Card>
                </div>
            </div>)
    }
}

export default TreeDictionary