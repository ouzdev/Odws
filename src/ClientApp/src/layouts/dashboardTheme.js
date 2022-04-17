import {createTheme} from '@mui/material/styles';
import {useState} from 'react';

export const dashboardTheme = createTheme({
    
    typography: {
        fontFamily: [
          '-apple-system',
          'BlinkMacSystemFont',
          '"Segoe UI"',
          'Roboto',
          '"Helvetica Neue"',
          'Arial',
          'sans-serif',
          '"Apple Color Emoji"',
          '"Segoe UI Emoji"',
          '"Segoe UI Symbol"',
        ].join(','),
      },
      palette: { 
        mode: useState.mode,
    }
});