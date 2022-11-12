import { Avatar, Pagination, Table } from "@douyinfe/semi-ui";
import { Component, ReactNode } from "react";
import userinfoapi from "../../../apis/userinfoapi";
import { GetUserInfoInput } from "../../../modules/userInfo/GetUserInfoInput";
import { UserInfoDto } from "../../../modules/userInfo/UserInfoDto";

const columns = [
    {
        title: '昵称',
        dataIndex: 'name',
        render: (value: any) => `${value}`,
    },
    {
        title: '账号',
        dataIndex: 'userName',
        render: (value: any) => `${value}`,
    },
    {
        title: '密码',
        dataIndex: 'passWord',
        render: (value: any) => `${value}`,
    },
    {
        title: '头像',
        dataIndex: 'avatar',
        render: (value: any) =>
            <Avatar size="small" src={value} style={{ marginRight: 4 }}>
            </Avatar>,
    },
    {
        title: '账号状态',
        dataIndex: 'status',
        render: (value: any) => `${value}`,
    },
]

interface IProps {
    input: GetUserInfoInput | null;
    onRef: any,
    inputonChange: any
}
interface IState {
    data: {
        items: UserInfoDto[],
        totalCount: number
    },

}

class TabUserInfo extends Component<IProps, IState>{

    state: Readonly<IState> = {
        data: {
            items: [],
            totalCount: 0
        }
    }

    constructor(props: IProps) {
        super(props);
        this.getUserInfo(null);
    }

    componentDidMount(): void {
        this.props.onRef(this)
    }

    getUserInfo(input: null | any) {
        userinfoapi.GetListAsync(input ?? this.props.input)
            .then((res: any) => {
                this.setState({
                    data: res.data
                })
            })
    }

    paginationChange(value: any) {
        var input = {
            page: value,
            pageSize: this.props.input?.pageSize,
            keywords: this.props.input?.keywords,
            startTime: this.props.input?.startTime,
            endTime: this.props.input?.endTime
        };
        this.props.inputonChange(input)
        this.getUserInfo(input)
    }

    render(): ReactNode {
        const scroll = { y: 400, x: 1200 }

        var { data } = this.state
        return <div>
            <Table columns={columns} dataSource={data.items} pagination={false} scroll={scroll}>
            </Table>
            <Pagination
                total={data.totalCount}
                showTotal
                onChange={(value) => this.paginationChange(value)}
                style={{ marginBottom: 12 }}
                pageSize={this.props.input?.pageSize}
                currentPage={this.props.input?.page}></Pagination>
        </div>
    }
}

export default TabUserInfo