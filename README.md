基于ASP.net mvc5+entityframework6的一个车辆商店管理系统，目标框架为.net framework 4.5，数据库为sql server，前端采用jQuery设计。

功能上设计较为简单，一个登录+增删查改管理系统，适合入门者学习或当期末作业。

登录上采用明文登录，加入了登录校验功能，系统会检查当前用户的登录状态才会跳转下一个界面。

登录角色分为管理员和普通用户。管理员可以查询新增用户及用户信息，可以查看用户订单，并对其状态进行修改。

![image](https://github.com/Mikusososocute/-ASP.NET-MVC-ShopCarManager/assets/98662137/3cad2fd9-4140-4d25-b663-fe40b794eaf1)

![image](https://github.com/Mikusososocute/-ASP.NET-MVC-ShopCarManager/assets/98662137/1c0eb89c-e1fb-4ab4-9f52-1545bfabca95)

![image](https://github.com/Mikusososocute/-ASP.NET-MVC-ShopCarManager/assets/98662137/f22b6a3e-81e6-4890-b938-9b21b68a128a)

用户可以对其订单信息进行管理， 包含查询、新增、修改、删除等功能

![image](https://github.com/Mikusososocute/-ASP.NET-MVC-ShopCarManager/assets/98662137/ed1f2760-feee-43ce-a11d-57bd1f90733b)

![image](https://github.com/Mikusososocute/-ASP.NET-MVC-ShopCarManager/assets/98662137/11de7378-bc07-4a0c-a7b8-329619121467)

目前存在已知问题：

系统运行后，在未登录的情况直接进入用户页面，理论上会被拦截，但系统报下面这样的错误，希望有大佬能解决

![e32e17bf67d7567a48cde9023bb03e0](https://github.com/Mikusososocute/-ASP.NET-MVC-ShopCarManager/assets/98662137/15cb0b62-3afd-439d-8c21-670a0c1f9394)
