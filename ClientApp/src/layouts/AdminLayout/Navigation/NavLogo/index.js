import React from "react";
import Logo from "../../../../assets/images/Logo.jpeg";

const NavLogo = () => {
  return (
    <React.Fragment>
      <div className="navbar-brand header-logo mb-6">
        <img src={Logo} alt="Logo" width={275} height={70} />
      </div>
    </React.Fragment>
  );
};

export default NavLogo;
