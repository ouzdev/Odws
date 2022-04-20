import { useSelector} from 'react-redux';
import { Layout } from './layouts/Layout';
import './custom.css'
import { ThemeProvider } from "@mui/material/styles";
import { darkTheme, lightTheme } from "./layouts/dashboardTheme";


function App(){
  const theme = useSelector((state) => state.theme);


    return (
      <ThemeProvider theme={theme.darkTheme ? darkTheme : lightTheme}>

      <Layout></Layout>
      </ThemeProvider>
    );
  }
  export default App;

