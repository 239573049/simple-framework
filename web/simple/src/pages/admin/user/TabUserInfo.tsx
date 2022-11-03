import { Avatar, Table } from "@douyinfe/semi-ui";
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
    onRef: any
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
        this.getUserInfo();
    }

    componentDidMount(): void {
        this.props.onRef(this)
    }

    getUserInfo() {
        userinfoapi.GetListAsync(this.props.input)
            .then((res: any) => {
                this.setState({
                    data: res.data
                })
            })
    }

    render(): ReactNode {
        var { data } = this.state
        return <Table columns={columns} dataSource={data.items} />
    }
}

export default TabUserInfo