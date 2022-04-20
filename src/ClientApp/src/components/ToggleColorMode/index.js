import React from "react";
import { useSelector, useDispatch } from 'react-redux';
import IconButton from '@mui/material/IconButton';
import Brightness4Icon from '@mui/icons-material/Brightness4';
import Brightness7Icon from '@mui/icons-material/Brightness7';
import { toggleTheme } from "../../services/reducers/themeSlice";

export default function ToggleColorMode() {
  const theme = useSelector((state) => state.theme);
  const dispatch = useDispatch();  
    return (
      <IconButton sx={{ ml: 1 }} onClick={() => dispatch(toggleTheme())} color="inherit">
      {theme.darkTheme === false ? <Brightness4Icon />:<Brightness7Icon />}
    </IconButton>    
    );
  }