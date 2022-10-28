import { Component, ReactNode } from "react";
import { Outlet } from "react-router-dom";
import { Layout, Nav, Button, Breadcrumb, Skeleton, Avatar } from '@douyinfe/semi-ui';
import { IconBell, IconHelpCircle, IconBytedanceLogo, IconHome, IconHistogram, IconLive, IconSetting } from '@douyinfe/semi-icons';

const { Header, Footer, Sider, Content } = Layout;

class Admin extends Component {

    constructor(props: any) {
        super(props)
    }
    render(): ReactNode {
        return (
            <Layout style={{ border: '1px solid var(--semi-color-border)', height: '100%' }}>
                <Sider style={{ backgroundColor: 'var(--semi-color-bg-1)' }}>
                    <Nav
                        defaultSelectedKeys={['Home']}
                        style={{ maxWidth: 220, height: '100%' }}
                        items={[
                            {
                                itemKey: 'Home',
                                text: '首页',
                                link: '/',
                                icon: <IconHome size="large" />
                            },
                            {
                                itemKey: 'Histogram',
                                text: '用户管理',
                                link: '/user',
                                icon: <IconHistogram size="large" />
                            },
                            {
                                itemKey: 'Live',
                                text: '测试功能',
                                icon: <IconLive size="large" />,
                                items: [
                                    {
                                        itemKey: 'operation-management',
                                        text: '运营管理',
                                        items: [
                                            '人员管理',
                                            '人员变更'
                                        ]
                                    }
                                ]
                            },
                            {
                                itemKey: 'Setting',
                                text: '设置',
                                icon: <IconSetting size="large" />
                            },
                        ]}
                        header={{
                            logo: <img src="//lf1-cdn-tos.bytescm.com/obj/ttfe/ies/semi/webcast_logo.svg" />,
                            text: 'Simple 后台管理',
                        }}
                        footer={{
                            collapseButton: true,
                        }}
                    />
                </Sider>
                <Layout>
                    <Header style={{ backgroundColor: 'var(--semi-color-bg-1)' }}>
                        <Nav
                            mode="horizontal"
                            footer={
                                <>
                                    <Button
                                        theme="borderless"
                                        icon={<IconBell size="large" />}
                                        style={{
                                            color: 'var(--semi-color-text-2)',
                                            marginRight: '12px',
                                        }}
                                    />
                                    <Button
                                        theme="borderless"
                                        icon={<IconHelpCircle size="large" />}
                                        style={{
                                            color: 'var(--semi-color-text-2)',
                                            marginRight: '12px',
                                        }}
                                    />
                                    <Avatar color="orange" size="small">
                                        YJ
                                    </Avatar>
                                </>
                            }
                        ></Nav>
                    </Header>
                    <Content
                        style={{
                            padding: '24px',
                            backgroundColor: 'var(--semi-color-bg-0)',
                        }}
                    >
                        <Breadcrumb
                            style={{
                                marginBottom: '24px',
                            }}
                            routes={['首页', '详情页']}
                        />
                        <div
                            style={{
                                borderRadius: '10px',
                                border: '1px solid var(--semi-color-border)',
                                height: '376px',
                                padding: '32px',
                            }}
                        >
                            <Skeleton placeholder={<Skeleton.Paragraph rows={2} />} loading={false}>
                                <Outlet></Outlet>
                            </Skeleton>
                        </div>
                    </Content>
                    <Footer
                        style={{
                            display: 'flex',
                            justifyContent: 'space-between',
                            padding: '20px',
                            color: 'var(--semi-color-text-2)',
                            backgroundColor: 'rgba(var(--semi-grey-0), 1)',
                        }}
                    >
                        <span
                            style={{
                                display: 'flex',
                                alignItems: 'center',
                            }}
                        >
                            <IconBytedanceLogo size="large" style={{ marginRight: '8px' }} />
                            <span>Copyright © 2019 ByteDance. All Rights Reserved. </span>
                        </span>
                        <span>
                            <span style={{ marginRight: '24px' }}>平台客服</span>
                            <span>反馈建议</span>
                        </span>
                    </Footer>
                </Layout>
            </Layout>
        )
    }
}
export default Admin;