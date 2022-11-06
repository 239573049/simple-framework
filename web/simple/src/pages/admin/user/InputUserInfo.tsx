import { Button, DatePicker, Input } from "@douyinfe/semi-ui";
import { Component, ReactNode } from "react";
import { IconSearch } from '@douyinfe/semi-icons';

export declare type OnChangeType = (date?: Date | Date[] | string | string[], dateStr?: string | string[] | Date | Date[]) => void;

interface IProps {
    keywords: string | undefined;
    startTime: string | null;
    endTime: string | null;
    keywordsChange: (e: string) => void;
    timeChange: OnChangeType;
    OnClick: () => void;
}

class InputUserInfo extends Component<IProps>{

    render(): ReactNode {
        var { keywordsChange, timeChange } = this.props
        return (<div>
            <Input onChange={(value) => {
                keywordsChange(value)
            }} value={this.props.keywords} style={{ width: "200px", marginRight: "8px" }} prefix={<IconSearch />} showClear ></Input>
            <DatePicker onChange={(value) => {
                timeChange(value)
            }} type="dateRange" density="compact" style={{ width: 260, marginRight: "8px" }} />
            <Button icon={<IconSearch />} aria-label="截屏" onClick={this.props.OnClick} />
        </div>)
    }
}

export default InputUserInfo