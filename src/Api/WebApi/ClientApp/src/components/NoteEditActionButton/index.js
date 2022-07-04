import React from 'react';
import Fab from '@mui/material/Fab';
import AddIcon from '@mui/icons-material/Add';

export default function NoteEditActionButton() {
    const style = {
        margin: 0,
        top: 'auto',
        right: 20,
        bottom: 20,
        left: 'auto',
        position: 'fixed',
    };
    return(
        <Fab color="success" style={style} aria-label="add">
        <AddIcon />
      </Fab>
    );
}