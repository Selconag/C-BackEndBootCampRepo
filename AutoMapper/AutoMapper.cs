/*
 * AutoMapper nedir?
 * AutoMapper .NET geliştirme ortamında kullanılan sınıflar arası bir veri transferi frameworküdür. 
 * Bu framework sınıftan sınıfa veri aktarımına yardımcı olabildiği gibi aynı zamanda daha karmaşık yapılar olan Data Transfer Object(DTO) objeleri ve başka türler arasında veri aktarımı da yapabilmektedir.
 * AutoMapper şu şekilde çalışır:

    1) Yapılandırma: Kaynak ve hedef sınıflar arasındaki eşlemeleri tanımlarsınız. 
    AutoMapper, bu eşlemeleri akıcı bir API veya öznitelikler kullanarak yapılandırmanıza olanak tanır.

    2) Haritalama: Verileri haritalandırmanız gerektiğinde bunu yapmak için AutoMapper'ı kullanabilirsiniz. 
       Bir kaynak nesnenin bir örneğini alır ve onu, yapılandırılmış eşleme kurallarına göre hedef nesnenin bir örneğiyle eşler.

    3) Otomatik Eşleme: AutoMapper, özellikleri eşleşen adlar ve türlerle otomatik olarak eşleyebilir.
       Ancak gerekirse belirli özellikler için varsayılan davranışı özelleştirebilir ve geçersiz kılabilirsiniz.

*       Csharp
        using AutoMapper;

        // Define your mapping configuration
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<SourceClass, DestinationClass>();
        });

        // Create a mapper instance
        var mapper = new Mapper(config);

        // Perform the mapping
        var sourceObject = new SourceClass { ... };
        var destinationObject = mapper.Map<DestinationClass>(sourceObject);
* 
 */