import { FormControl } from '@chakra-ui/react';
import React, {createRef} from 'react'
import FormInput from '../../../components/Form/FormInput';
const FormSignUp = () => {
    const emailInput = createRef<HTMLInputElement>();
    const passwordInput = createRef<HTMLInputElement>();
    const comfirmInput = createRef<HTMLInputElement>();
    const loginHandler = (e: React.SyntheticEvent<HTMLInputElement>) => {
      e.preventDefault();
      console.log(emailInput.current?.value);
      console.log(passwordInput.current?.value);
    };
  return (
    <FormControl>
      <FormInput ref={emailInput} textLabel={'Email'} />
      <FormInput ref={passwordInput} textLabel={'Password'} typeInput="password" />
      <FormInput ref={passwordInput} textLabel={'Password'} typeInput="select" />
      <FormInput ref={comfirmInput} textLabel={'Comfirm password'} />





    </FormControl>
  )
}

export default FormSignUp