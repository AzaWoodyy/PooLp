using Xunit;
using TP2;
using Humain = TP2.Humain;

namespace testTP2;

public class UnitTest1 {
    [Fact]
    public void getEtuTest() {
        Etudiant enzo = new Etudiant("Neault", "Enzo", "2001", "119DIDJZ3R5");
        Assert.Equal("Neault Enzo 119DIDJZ3R5", enzo.getEtu());
    }

    [Fact]
    public void SupToTest() {
        Etudiant enzo = new Etudiant("Neault", "Enzo", "2001", "119DIDJZ3R5", 10);
        Etudiant enzoV2 = new Etudiant("Neaulte", "eneault", "2001", "098JI8748FH3", 15);
        Assert.Equal(false, enzo > enzoV2);
    }

    [Fact]
    public void InfToTest() {
        Etudiant enzo = new Etudiant("Neault", "Enzo", "2001", "119DIDJZ3R5", 10);
        Etudiant enzoV2 = new Etudiant("Neaulte", "eneault", "2001", "098JI8748FH3", 15);
        Assert.Equal(true, enzo < enzoV2);
    }

    [Fact]
    public void calculAgeTest() {
        Humain enzo = new Humain("Neault", "Enzo", "2001");
        Assert.Equal(21, enzo.age);
    }
}