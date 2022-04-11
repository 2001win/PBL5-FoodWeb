import { Select } from '@chakra-ui/react';
import React from 'react';

interface SelectProps {
    textDisplay: string;
    selectOptions: any;
  }
  const SelectOption = (props: SelectProps) => {
    return 
        <div><Select [(ngModel)]=props.textDisplay>
            <option *ngFor="let n of props.selectOptions"> {{n}}</option>
        </Select>
    </div>
  };
  
  export default SelectOption;