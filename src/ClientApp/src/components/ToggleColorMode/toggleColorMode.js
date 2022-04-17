import {createTheme,ThemeProvider} from '@mui/material/styles';
import React, { useState } from "react";
import Switch from '@mui/material/Switch';


export default function ToggleColorMode() {
    const [darkState, setDarkState] = useState(false);
    const palletType = darkState ? "dark" : "light";
    const darkTheme = createTheme({
      palette: {
        type: palletType,
      }
    });
    const handleThemeChange = () => {
      setDarkState(!darkState);
    };
    
    return (
      <ThemeProvider theme={darkTheme}>
        <Switch checked={darkState} onChange={handleThemeChange} />
      </ThemeProvider>
    );
  }